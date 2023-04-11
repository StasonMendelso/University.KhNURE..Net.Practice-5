# University.KhNURE..Net.Practice-5

## What is the project about?

Repository is for educational purpose - doing practical class' [task №5](Методичні%20вказівки%20до%20ПЗ%205.pdf) on the
discipline *"Programming on the .Net platform"* in
the university "[Kharkiv National University of Radio Electronics][1]".

## What is the purpose of this project?

The **purpose** of the project is ***doing practical task №5*** on the discipline *"Programming on the .Net platform"*.

## Getting Started

There isn't a real or PET project, it's project about doing the practical task from discipline in university. So, you
need
download the code from the **main** branch for showing the completed task. For this, see the sections below.

### Prerequisites

For running the project you needn't nothing except IDEA for running the code.

### Installation Instruction

#### How to download project on my local machine?

For downloading the project locally you can use two variants:

1. Download the ZIP archive from the repository page.

   The method is easy, the next steps helps you:
2. Find the button `Code` and press it.
3. Find the button `Download ZIP` and press it. The downloading must start.
4. Unzip the archive in soe directory and run the IDEA in this directory.

Project has been installed. After opening it in your IDEA, the `Maven` downloads
some additional dependencies.

1. Use the `Git` for downloading the repository locally.

   The method a lit bit difficult, but the project will be downloaded with the help
   of several commands, and not manually, as in the previous method. For this method
   you **need** to [install][4] the `Git Bash` on your computer, make some configuration and have a primary skill of
   using this system of version control.
2. Enter your [name][5], [email][6] of GitHub account locally on your machine.
3. Create an empty directory and initialize it as git repository. Use the next
   command - `git init`.
4. Adds this repository to yours with name `origin` (you can change it, if you want):
    ```
   $ git remote add origin git@github.com:StasonMendelso/University.KhNURE..Net.Practice-5.git
   ```
   But you need configure your SSH connection to your GitHub profile in Git Bash. See more [here][7].

   For viewing that the repository has been added successfully to your local
   repository, you need execute the next command and get the following result:
   ```
   $ git remote -v
   ```
   ![git remote repository](images/image.png)

   After this step your local repository has got a 'connection' to the remote
   project from the GitHub repository.
5. For downloading the project use the following command:
   ```
   $ git pull origin main
   ```
   After these steps your project directory must contain the project files from
   GitHub repository. In addition to, you can create a new branch, make some
   changes and create a pull request for suggesting your improvements. Also, all
   changes are observed by the `git` and you can always make a rollback of
   all changes `git reset --hard`.

### Running the application

Run the application using the [Demo](Practice5/Demo.cs) class, where you can run the main method with all subtasks simultaneously.

## Author

* **Stanislav Hlova** - *All work* - [StasonMendelso](https://github.com/StasonMendelso)

[1]:https://nure.ua/

[4]:https://git-scm.com/downloads

[5]:https://docs.github.com/en/get-started/getting-started-with-git/setting-your-username-in-git

[6]:https://docs.github.com/en/account-and-profile/setting-up-and-managing-your-personal-account-on-github/managing-email-preferences/setting-your-commit-email-address

[7]:https://docs.github.com/en/authentication/connecting-to-github-with-ssh