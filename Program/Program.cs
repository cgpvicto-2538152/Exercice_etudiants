using BibliothequeEtudiant;

class Program
{
    static void Main(string[] args)
    {
        Etudiant etudiant = new Etudiant("Doe", "John", true);
        Console.WriteLine(etudiant);
        etudiant.DiplomeEtudiant(false);
        Console.WriteLine(etudiant);
    }
}
