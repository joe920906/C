using System;

public class PhoneList
{
    public string HomePhone { get; set; }
    public string BusinessPhone { get; set; }
    public string CellPhone { get; set; }

    public PhoneList(string homePhone, string businessPhone, string cellPhone)
    {
        HomePhone = homePhone;
        BusinessPhone = businessPhone;
        CellPhone = cellPhone;
    }
}

public class Cards
{
    public string Name { get; set; }
    public string Occupation { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public PhoneList Phones { get; set; }

    public Cards(string name, string occupation, int age, string email, PhoneList phones)
    {
        Name = name;
        Occupation = occupation;
        Age = age;
        Email = email;
        Phones = phones;
    }

    public string GetCard()
    {
        return $"--- 名片資料 ---\n" +
               $"姓名：{Name}\n" +
               $"職業：{Occupation}\n" +
               $"年齡：{Age}\n" +
               $"電子郵件：{Email}\n" +
               $"住家電話：{Phones.HomePhone}\n" +
               $"公司電話：{Phones.BusinessPhone}\n" +
               $"手機：{Phones.CellPhone}\n";
    }
}

class Program
{
    static void Main(string[] args)
    {
        PhoneList phoneList = new PhoneList("03-5557284", "03-5585366", "0909-721-962");
        Cards card = new Cards("譚家安", "學生", 21, "joe920906@gmail.com", phoneList);

        Console.WriteLine(card.GetCard());
    }
}
