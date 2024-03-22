namespace Scan_Product_TTTQ.Domain.ValueObjects.Common;
public class PaginationResponse<T>
{
    public PaginationResponse(List<T> data, int page, int pageSize, int count)
    {
        Data = data;
        CurrentPage = page;
        PageSize = pageSize;
        TotalCount = count;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);
    }

    public PaginationResponse()
    {
    }

    public List<T> Data { get; set; }

    public int CurrentPage { get; set; }

    public int TotalPages { get; set; }

    public int TotalCount { get; set; }

    public int PageSize { get; set; }

    public bool HasPreviousPage => CurrentPage > 1;

    public bool HasNextPage => CurrentPage < TotalPages;
}
