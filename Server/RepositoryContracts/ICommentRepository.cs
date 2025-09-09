using Entities;

namespace RepositoryContracts;

public interface ICommentRepository
{
    void Add(Comment comment);
    void Update(Comment comment);
    void Delete(int id);
    Comment? GetById(int id);
    List<Comment> GetAll();
}
