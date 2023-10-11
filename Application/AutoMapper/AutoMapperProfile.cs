using Application.ViewModels;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Usuario, UsuarioViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.DataNasc, opt => opt.MapFrom(src => src.DataNasc))
                .ForMember(dest => dest.NomeCompleto, opt => opt.MapFrom(src => src.NomeCompleto))
                .ForMember(dest => dest.Telefone, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Genero, opt => opt.MapFrom(src => src.GeneroId))
                .ForMember(dest => dest.UF, opt => opt.MapFrom(src => src.Enderecos.Where(x => x.UsuarioId == src.Id).Select(x => x.UF).FirstOrDefault()))
                .ForMember(dest => dest.CodigoPostal, opt => opt.MapFrom(src => src.Enderecos.Where(x => x.UsuarioId == src.Id).Select(x => x.CodigoPostal).FirstOrDefault()))
                .ForMember(dest => dest.Cidade, opt => opt.MapFrom(src => src.Enderecos.Where(x => x.UsuarioId == src.Id).Select(x => x.Cidade).FirstOrDefault()))
                .ForMember(dest => dest.Numero, opt => opt.MapFrom(src => src.Enderecos.Where(x => x.UsuarioId == src.Id).Select(x => x.Numero).FirstOrDefault()))
                .ForMember(dest => dest.Bairro, opt => opt.MapFrom(src => src.Enderecos.Where(x => x.UsuarioId == src.Id).Select(x => x.Bairro).FirstOrDefault()))
                .ForMember(dest => dest.Logradouro, opt => opt.MapFrom(src => src.Enderecos.Where(x => x.UsuarioId == src.Id).Select(x => x.Logradouro).FirstOrDefault()));
            CreateMap<AvaliacaoCurso, AvaliacaoCursoViewModel>().ReverseMap();
            CreateMap<Categoria, CategoriaViewModel>().ReverseMap();
            CreateMap<Compra, CompraViewModel>().ReverseMap();
            CreateMap<Curso, CursoViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.NivelId, opt => opt.MapFrom(src => src.CursosNiveis.FirstOrDefault().NivelEscolaridade.Id))
                .ForMember(dest => dest.Categoria, opt => opt.MapFrom(src => src.Categorias))
                .ForMember(dest => dest.UsuarioCurso, opt => opt.MapFrom(src => src.UsuariosCursos))
                .ForMember(dest => dest.Materias, opt => opt.MapFrom(src => src.MateriasCursos))
                .ForMember(dest => dest.CursosNiveis, opt => opt.MapFrom(src => src.CursosNiveis.FirstOrDefault()))
                .ForMember(dest => dest.Criador, opt => opt.MapFrom(src => src.UsuariosCursos.FirstOrDefault().User.NomeCompleto));
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Genero, GeneroViewModel>().ReverseMap();
            CreateMap<UsuarioCurso, UsuarioCursoViewModel>()
                .ForMember(dest => dest.Curso, opt => opt.MapFrom(src => src.Cursos))
                .ForMember(dest => dest.Usuario, opt => opt.MapFrom(src => src.User));
            CreateMap<NivelEscolaridade, NivelEscolaridadeViewModel>().ReverseMap();
            CreateMap<Materia, MateriaViewModel>()
                .ForMember(dest => dest.MateriaCursos, opt => opt.MapFrom(src => src.MateriaCursos));
            CreateMap<CursosNiveis, CursosNiveisViewModel>().ReverseMap();
            CreateMap<MateriaCursos, MateriaCursosViewModel>().ReverseMap();
        }
    }
}
