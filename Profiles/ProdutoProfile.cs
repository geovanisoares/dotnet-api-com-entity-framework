using AutoMapper;
using dotnet_api_com_entity_framework.Data.Dtos;
using dotnet_api_com_entity_framework.Model;
using System.Spatial;

namespace dotnet_api_com_entity_framework.Profiles
{
    public class ProdutoProfile: Profile
    {
        public ProdutoProfile()
        {
            this.CreateMap<CreateProdutoDto, Produto>();
            this.CreateMap<UpdateProdutoDto, Produto>();
            this.CreateMap<Produto, UpdateProdutoDto>();
            this.CreateMap<Produto, ReadProdutoDto>();
            this.CreateMap<ReadProdutoDto, Produto>();

        }
    }
}
