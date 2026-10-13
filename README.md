# PayIt Web 💳

Version navigateur de PayIt, projet de démonstration bancaire en **C# / Blazor WebAssembly (.NET 10)**.

## Fonctionnalités

Connexion, inscription, soldes, ajout et retrait fictifs, transferts entre comptes, historique filtrable, carte virtuelle, blocage/réactivation, changement de PIN.

## Démonstration

- `gwenaelle@payit.fr` / `1234`
- `marie@payit.fr` / `5678`

**Aucun argent réel.** Données uniquement en mémoire, réinitialisées à chaque rechargement. Les mots de passe et PIN sont fictifs et la sécurité n'est pas adaptée à une application bancaire réelle.

## Lancer localement

Sur un ordinateur avec le SDK .NET 10 :

```bash
dotnet restore
dotnet run
```

Ouvrir l'adresse locale affichée dans le terminal.

## Publication GitHub Pages

1. Créer un dépôt GitHub pour ce dossier, branche `main`.
2. Envoyer tous les fichiers, y compris `.github/workflows/deploy.yml`.
3. Dans **Settings → Pages → Build and deployment**, sélectionner **GitHub Actions**.
4. L'action publie automatiquement à chaque push sur `main`.
5. Mettre l'URL GitHub Pages dans le portfolio.

Le workflow configure automatiquement le chemin de base pour un dépôt de projet (`https://utilisateur.github.io/nom-du-depot/`).

## Note technique

Projet fourni sous forme de sources. La compilation n'a pas été exécutée dans l'environnement de génération : tester avec .NET 10 avant publication.
