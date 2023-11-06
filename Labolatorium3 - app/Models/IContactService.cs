namespace Labolatorium3___app.Models
{
    public interface IContactService
    {
        void add(Contact contact);
        void RemoveByID(int id);
        void Update(Contact  contact);
        List<Contact> FindAll();
        Contact? FindByID(int id);
    }
}
