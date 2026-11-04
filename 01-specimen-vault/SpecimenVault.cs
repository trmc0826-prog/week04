public class SpecimenVault
{
    private List<string> specimens = new List<string>();

    public void Add(string specimen)
    {
        specimens.Add(specimen);
    }

    public bool Remove(string specimen)
    {
        // TODO
        return specimens.Remove(specimen);
    }

    public void PrintAll()
    {
        foreach (string specimen in specimens)
        {
            Console.WriteLine(specimen);
        }
    }
}
