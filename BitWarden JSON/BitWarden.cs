
public class Rootobject
{
    public bool encrypted { get; set; }
    public Collection[] collections { get; set; }
    public Item[] items { get; set; }
}

public class Collection
{
    public string id { get; set; }
    public string organizationId { get; set; }
    public string name { get; set; }
    public object externalId { get; set; }
}

public class Item
{
    public Passwordhistory[] passwordHistory { get; set; }
    public DateTime revisionDate { get; set; }
    public DateTime creationDate { get; set; }
    public object deletedDate { get; set; }
    public string id { get; set; }
    public string organizationId { get; set; }
    public object folderId { get; set; }
    public int type { get; set; }
    public int reprompt { get; set; }
    public string name { get; set; }
    public string notes { get; set; }
    public bool favorite { get; set; }
    public Securenote secureNote { get; set; }
    public string[] collectionIds { get; set; }
    public Identity identity { get; set; }
    public Card card { get; set; }
    public Login login { get; set; }
}

public class Securenote
{
    public int type { get; set; }
}

public class Identity
{
    public object title { get; set; }
    public string firstName { get; set; }
    public object middleName { get; set; }
    public string lastName { get; set; }
    public object address1 { get; set; }
    public object address2 { get; set; }
    public object address3 { get; set; }
    public object city { get; set; }
    public object state { get; set; }
    public object postalCode { get; set; }
    public object country { get; set; }
    public object company { get; set; }
    public object email { get; set; }
    public object phone { get; set; }
    public object ssn { get; set; }
    public object username { get; set; }
    public object passportNumber { get; set; }
    public string licenseNumber { get; set; }
}

public class Card
{
    public string cardholderName { get; set; }
    public string brand { get; set; }
    public string number { get; set; }
    public string expMonth { get; set; }
    public string expYear { get; set; }
    public string code { get; set; }
}

public class Login
{
    public object[] fido2Credentials { get; set; }
    public Uri[] uris { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public object totp { get; set; }
}

public class Uri
{
    public object match { get; set; }
    public string uri { get; set; }
}

public class Passwordhistory
{
    public DateTime lastUsedDate { get; set; }
    public string password { get; set; }
}
