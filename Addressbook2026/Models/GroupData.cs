namespace Addressbook2026;

public class GroupData
{
    public GroupData(string name)
    {
        GroupName = name;
    }

    public GroupData(string name, string header, string footer)
    {
        GroupName = name;
        GroupHeader = header;
        GroupFooter = footer;
    }

    public string GroupName { get; set; }
    public string GroupHeader { get; set; }
    public string GroupFooter { get; set; }
}
