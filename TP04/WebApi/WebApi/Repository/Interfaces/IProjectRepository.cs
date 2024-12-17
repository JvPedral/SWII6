// João Vitor Pedral CB3022391
// Rodrigo Braga CB3018105

using WebApi.Models;

namespace WebApi.Repository.Interfaces
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAll();
        Task<Project> GetById(int id);
        Task<bool> Insert(Project project);
        Task<bool> Update(Project project);
        Task<bool> Delete(Project project);
    }
}
