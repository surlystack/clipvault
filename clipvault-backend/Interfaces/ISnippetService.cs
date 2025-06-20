using ClipVault.Dtos;
namespace ClipVault.Interfaces;

public interface ISnippetService
{
    Task<SnippetResponseDto> CreateSnippetAsync(SnippetCreateDto snippetDto);
    Task<List<SnippetResponseDto>> GetAllSnippetsAsync();
    Task<SnippetResponseDto?> GetSnippetByIdAsync(int id);
    Task<SnippetResponseDto?> UpdateSnippetAsync(int id, SnippetUpdateDto snippetDto);
    Task<List<SnippetResponseDto>> SearchSnippetsAsync(string? keyword, string? language, List<string>? tagNames);
    Task ReplaceTagsForSnippetAsync(int snippetId, List<string> tagNames);
    Task RemoveTagsFromSnippetAsync(int snippetId, List<string> tagNames);
    Task<SnippetResponseDto?> AddTagsToSnippetAsync(int snippetId, List<string> tagNames);
    Task<List<SnippetResponseDto>> GetSnippetsDtoByTagAsync(string tagName);
    Task<bool> SoftDeleteSnippetAsync(int id);
}
