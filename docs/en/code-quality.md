# Evaluate Code Quality

We will use a service called Codacy to evaluate the quality of the code.

## What is Codacy?

It's a code review type CI service. There are several code review services out there, but we'll use this one because it reviews C# and is easy to integrate with GitHub.
This service is free in public repositories.

Official Website
[codacy](https://www.codacy.com/)

## How to use

First, create a Codacy account; since it will be integrated with GitHub, sign up with your GitHub account to ensure smooth integration.
After creating your account, you will be prompted to select the repository you want to integrate.
By default, the main branch is used for code analysis. Since development is often done on the develop branch, you may want to change the target branch as shown below.

![](https://github.com/hrntsm/zenn_articles/blob/master/books/grasshopper-ci/image/codacy.png?raw=true)

If you have a successful integration, the code is automatically analyzed, and when you open the files, you can see how the code quality is for each file as shown below. You can see that only one file, "GrasshopperCISample/Util.cs", has a quality C.

![](https://github.com/hrntsm/zenn_articles/blob/master/books/grasshopper-ci/image/quality.png?raw=true)

If you select the file to see where the quality is degraded, you can use it as a reference when making corrections.

## Pull request to work on

Let's install codacy plugin from Github's Marketplace.
[Marketplace/Apps/Codacy](https://github.com/marketplace/codacy)

## The advantages of doing this

This service is only doing static analysis and not looking for build errors and so on. So what you'll see as a result, for example, is the following

- Unused variables.
- The variable can be readonly
- There are duplicates in the code
- There are redundant expressions (e.g. unnecessary () etc.)

Of course, you can build the code without fixing them, but they are desirable for the readability of the code.
The parts that don't need to be fixed will help you the next day if you clean them up as much as you can for your unknowing self, who will be reading this code the next day or later.

---

### Prev
[Built with GitHub Actions](build-with-github-actions)

### Next
[Evaluate Code Maintainability](code-maintenace)

[Return to Top](tutorial-chapters)
