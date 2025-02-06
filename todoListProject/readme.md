### Explications du projet
Namespace et Classes:

-namespace TodoApp: Définit un espace de noms pour organiser le code.
-class Program: Contient la méthode principale qui exécute le programme.
-class TodoList: Gère la liste des tâches à faire.
-class TodoTask: Représente une tâche individuelle avec un ID et une description.

### Fonctionnalités:

-Ajouter une tâche: Permet à l'utilisateur d'ajouter une nouvelle tâche avec une description.
-Afficher les tâches: Affiche toutes les tâches existantes avec leurs ID.
-Supprimer une tâche: Supprime une tâche en fonction de son ID.

### Boucle de Menu:

Le programme utilise une boucle while pour afficher un menu et exécuter les actions en fonction des choix de l'utilisateur.

### Comment exécuter ce projet
-Installez le .NET SDK depuis le site officiel de .NET.
-Créez un nouveau projet console en utilisant la commande bash:
"dotnet new console -n TodoApp"

-Remplacez le contenu du fichier Program.cs généré par le code ci-dessus.
Exécutez le projet en utilisant la commande bash:

"dotnet run"

### TODO : Feature 
 -la persistance des données.
 -l'interface utilisateur graphique.