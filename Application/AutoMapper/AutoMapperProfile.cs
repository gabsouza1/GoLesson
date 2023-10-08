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
                .ForMember(dest => dest.DataNasc, opt => opt.MapFrom(src => src.DataNasc))
                .ForMember(dest => dest.NomeCompleto, opt => opt.MapFrom(src => src.NomeCompleto))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
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
            CreateMap<Curso, CursoViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Genero, GeneroViewModel>().ReverseMap();
            CreateMap<UsuarioCurso, UsuarioCursoViewModel>().ReverseMap();
            CreateMap<NivelEscolaridade, NivelEscolaridadeViewModel>().ReverseMap();
            CreateMap<Materia, MateriaViewModel>().ReverseMap();
            CreateMap<CursosNiveis, CursosNiveisViewModel>().ReverseMap();
            CreateMap<MateriaCursos, MateriaCursosViewModel>().ReverseMap();
        }
    }
}
