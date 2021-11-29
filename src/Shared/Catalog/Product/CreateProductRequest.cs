using System;

namespace FSH.BlazorWebAssembly.Shared.Catalog;
public class CreateProductRequest
{
    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Rate { get; set; }

    public Guid BrandId { get; set; }

    public FileUploadRequest Image { get; set; }
}