using AutoMapper;
using MarktGuru.Application.Interfaces.Repositories;
using MarktGuru.Application.Wrappers;
using MarktGuru.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarktGuru.Application.Features.Products.Commands.CreateProduct
{
    public partial class CreateProductCommand : IRequest<Response<int>>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }

    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Response<int>>
    {
        private readonly IProductRepositoryAsync _productRepository;
        private readonly IMapper _mapper;
        
        public CreateProductCommandHandler(IProductRepositoryAsync productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        
        public async Task<Response<int>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request);
            product.Available = true;

            await _productRepository.AddAsync(product);
            return new Response<int>(product.Id);
        }
    }
}
