namespace BibliothequeEtudiant;

public class Etudiant
{
    private string? _nom;
    private string? _prenom;
    private bool _diplome;

    /// <summary>
    /// Le nom de l'étudiant
    /// </summary>
    public string Nom
    {
        get => _nom!;
        private set
        {
            if (value is null)
            {
                throw new ArgumentNullException(nameof(value), "Le nom ne peut pas être null.");
            }
            if (value == "")
            {
                throw new ArgumentException("Le nom ne peut pas être vide.", nameof(value));
            }
            _nom = value;
        }
    }

    /// <summary>
    /// Le prénom de l'étudiant
    /// </summary>
    public string Prenom
    {
        get => _prenom!;
        private set
        {
            if (value is null)
            {
                throw new ArgumentNullException(nameof(value), "Le prénom ne peut pas être null.");
            }
            if (value == "")
            {
                throw new ArgumentException("Le prénom ne peut pas être vide.", nameof(value));
            }
            _prenom = value;
        }
    }

    /// <summary>
    /// Si l'étudiant a un diplôme
    /// </summary>
    public bool Diplome
    {
        get => _diplome;
        private set
        {
            _diplome = value;
        }
    }


    /// <summary>
    /// Constructeur de l'étudiant
    /// </summary>
    /// <param name="nom">Le nom de l'étudiant</param>
    /// <param name="prenom">Le prénom de l'étudiant</param>
    /// <param name="diplome">Si l'étudiant a un diplôme</param>
    public Etudiant(string nom, string prenom, bool diplome)
    {
        if (string.IsNullOrWhiteSpace(nom))
        {
            throw new ArgumentException("Le nom ne peut pas être vide.", nameof(nom));
        }
        if (string.IsNullOrWhiteSpace(prenom))
        {
            throw new ArgumentException("Le prénom ne peut pas être vide.", nameof(prenom));
        }
        Nom = nom;
        Prenom = prenom;
        Diplome = diplome;
    }

    /// <summary>
    /// Modifie le diplôme de l'étudiant
    /// </summary>
    /// <param name="diplome">Booléen indiquant si l'étudiant a un diplôme</param>
    /// <returns>True si l'étudiant a un diplôme</returns>
    public bool DiplomeEtudiant(bool diplome)
    {
        Diplome = diplome;
        return diplome;
    }
    
    /// <summary>
    /// Affiche l'étudiant et son diplôme
    /// </summary>
    /// <returns>String représentant l'étudiant</returns>
    public override string ToString() => $"{Nom} {Prenom}, {Diplome}";
}
