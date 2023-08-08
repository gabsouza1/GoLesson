using Application.ViewModels;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ApplicationUser, UsuarioViewModel>().ReverseMap();
            CreateMap<Arquivo, ArquivoViewModel>().ReverseMap();
            CreateMap<Aula, AulaViewModel>().ReverseMap();
            CreateMap<AvaliacaoCurso, AvaliacaoCursoViewModel>().ReverseMap();
            CreateMap<Categoria, CategoriaViewModel>().ReverseMap();
            CreateMap<Cidade, CidadeViewModel>().ReverseMap();
            CreateMap<CodigoPostal, CodigoPostalViewModel>().ReverseMap();
            CreateMap<Compra, CompraViewModel>().ReverseMap();
            CreateMap<Curso, CursoViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Estado, EstadoViewModel>().ReverseMap();
            CreateMap<Favorito, FavoritoViewModel>().ReverseMap();
            CreateMap<FormaPagamento, FormaPagamentoViewModel>().ReverseMap();
            CreateMap<Genero, GeneroViewModel>().ReverseMap();
            CreateMap<Modulo, ModuloViewModel>().ReverseMap();
            CreateMap<NotaAvaliacao, NotaAvaliacaoViewModel>().ReverseMap();
            CreateMap<Pais, PaisViewModel>().ReverseMap();
            CreateMap<StatusPagamento, StatusPagamentoViewModel>().ReverseMap();
            CreateMap<UsuarioCurso, UsuarioCursoViewModel>().ReverseMap();
            CreateMap<UsuarioModulo, UsuarioModuloViewModel>().ReverseMap();
        }
    }
}
