using Application.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Application.Apps
{
    public class CursoApp : App<CursoViewModel, Curso>, ICursoApp
    {
        private readonly ICursoRepository _cursoRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ICursosNiveisRepository _cursosNiveisRepository;
        private readonly IUsuarioCursoRepository _usuarioCursoRepository;
        private readonly IMateriaCursosRepository _materiaCursosRepository;
        private readonly ICompraRepository _compraRepository;
        private readonly IMateriaRepository _materiaRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<CursoApp> _logger;
        public CursoApp(ICursoRepository cursoRepository, IMapper mapper
            , ILogger<CursoApp> logger, IUsuarioCursoRepository usuarioCursoRepository, 
            IMateriaCursosRepository materiaCursosRepository, IMateriaRepository materiaRepository,  
            ICursosNiveisRepository cursosNiveisRepository, ICompraRepository compraRepository, IUsuarioRepository usuarioRepository) : base(cursoRepository, mapper, logger)
        {
            _usuarioCursoRepository = usuarioCursoRepository;
            _mapper = mapper;
            _materiaCursosRepository = materiaCursosRepository;
            _materiaRepository = materiaRepository;
            _cursosNiveisRepository = cursosNiveisRepository;
            _cursoRepository = cursoRepository;
            _compraRepository = compraRepository;
            _usuarioRepository = usuarioRepository;
            _logger = logger;
        }

        public async Task<Curso> AddCursoAsync(CursoViewModel curso)
        {
            try {
                Curso newCurso = new()
                {
                    Id = curso.Id,
                    Acessibilidade = curso.Acessibilidade,
                    CategoriaId = curso.CategoriaId,
                    Capa = curso.Capa ?? null,
                    CreatedAt = DateTime.Now,
                    LastUpdatedAt = DateTime.Now,
                    Descricao = curso.Descricao,
                    NomeCurso = curso.NomeCurso,
                    Valor = curso.Valor,
                };

                var add = await _cursoRepository.Add(newCurso);
                if (add != null)
                {
                    foreach (var item in curso.Materias)
                    {
                        Materia materia = new()
                        {
                            Nome = item
                        };
                        var materiaAdd = await _materiaRepository.Add(materia);
                        MateriaCursos materiaCursos = new()
                        {
                            CursoId = add.Id,
                            MateriaId = materiaAdd.Id,
                        };
                        await _materiaCursosRepository.Add(materiaCursos);
                    }
                    CursosNiveis cursosNiveis = new()
                    {
                        NivelId = curso.NivelId,
                        CursoId = add.Id
                    };
                    await _cursosNiveisRepository.Add(cursosNiveis);

                    UsuarioCurso usuarioCurso = new()
                    {
                        UsuarioId = curso.UsuarioId,
                        CursoId = add.Id
                    };
                    await _usuarioCursoRepository.Add(usuarioCurso);

                }
                return newCurso;
            }
            catch(Exception ex) 
            {
                return null;
            }
            
        }

        public async Task<List<CursoViewModel?>> GetCursosByStudent(int id)
        {
            try {
                var comprasUsuarios = await _compraRepository.GetAll();
                var compraUsuario = comprasUsuarios.Where(cu => cu.UsuarioId == id).Select(cu => cu.Curso).ToList();
                List<CursoViewModel?> cursos = _mapper.Map<List<CursoViewModel?>>(compraUsuario);
                return cursos;
            }catch(Exception ex)
            {
                return  new List<CursoViewModel?>();    
            }
            
        }

        public async Task<List<CursoViewModel?>> GetCursosByTeacher(int id)
        {
            try {
                var usuarioCursos = await _usuarioCursoRepository.GetAll();
                var cursoProfessor = usuarioCursos.Where(uc => uc.UsuarioId == id).Select(uc => uc.Cursos).ToList();
                List<CursoViewModel?> cursos = _mapper.Map<List<CursoViewModel?>>(cursoProfessor);
                return cursos;
            }catch (Exception ex) 
            {
                return new List<CursoViewModel?>();
            }
            
        }

        public async Task<Curso> BuyCourse(int cursoId, int usuarioId)
        {
            try
            {
                var curso = await _cursoRepository.GetById(cursoId);
                var usuario = await _usuarioRepository.GetById(usuarioId);
                var professor = curso.UsuariosCursos?.FirstOrDefault().User;

                Compra compra = new()
                {
                    CursoId = cursoId,
                    UsuarioId = usuarioId,
                    DataCompra = DateTime.Now,
                    CreatedAt = DateTime.Now,
                    LastUpdatedAt = DateTime.Now
                };

                var result = await _compraRepository.Add(compra);

                var messageProfessor = @"<html>
                                    <body>  
                                        <h3>Parabéns, você tem um novo aluno!</h3>
                                        <br>
                                        <p>O aluno " + usuario.NomeCompleto + " acabou de adquirir seu curso " + curso.NomeCurso + 
                                        "<p>Entre em contato com ele pelo número " + usuario.PhoneNumber + " ou pelo Email " + usuario.Email + "</p>" +
                                    "</body>" +
                                    "</html>"
                ;

                var messageAluno = @"<html>
                                    <body>  
                                        <h3>Parabéns, você acaba de adiquirir um novo curso!</h3>
                                        <br>
                                        <p>Você adiquiriu com sucesso o curso " + curso.NomeCurso + " do professor " + professor.NomeCompleto +
                                        "<p>Entre em contato com ele pelo número " + professor.PhoneNumber + " ou pelo Email " + professor.Email + "</p>" +
                                    "</body>" +
                                    "</html>"
                ;

                SendEmail(messageProfessor, professor.Email);
                SendEmail(messageAluno, usuario.Email);

                return curso;
            }
            catch (Exception ex)
            {
                _logger.LogError("", ex.Message);
                return null;
            }
        }

        public void SendEmail(string messageContent, string addressMail)
        {
            string fromMail = "golesson.inc@gmail.com";
            string fromPassword = "wzur ujpv llri flvh";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Curso adiquirido";
            message.To.Add(new MailAddress(addressMail));
            message.Body = messageContent;
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }
    }
}
