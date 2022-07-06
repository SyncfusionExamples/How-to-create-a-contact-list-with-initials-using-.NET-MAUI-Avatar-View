namespace AvatarView_ContactList;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}
}

public class Contact
{
    public string Name { get; set; }
}

public class ContactsViewModel
{
    public List<Contact> ListOfContacts { get; set; }

    public ContactsViewModel()
    {
        ListOfContacts = new List<Contact>();

        ListOfContacts.Add(new Contact() { Name = "Tucker Davis" });
        ListOfContacts.Add(new Contact() { Name = "Elizabeth Ann" });
        ListOfContacts.Add(new Contact() { Name = "Lily Sue" });
        ListOfContacts.Add(new Contact() { Name = "Mary Margaret" });
        ListOfContacts.Add(new Contact() { Name = "Sophia Grace" });
        ListOfContacts.Add(new Contact() { Name = "Andrew James" });
        ListOfContacts.Add(new Contact() { Name = "George Frances" });
        ListOfContacts.Add(new Contact() { Name = "James Richard" });
        ListOfContacts.Add(new Contact() { Name = "John Peter" });
        ListOfContacts.Add(new Contact() { Name = "Logan James" });
    }
}


