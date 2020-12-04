# Create your own pages using GitHub Pages

Github Pages makes it easy to create a site.
Let's create a site to introduce the components we have created here.

## How to make

Open the Settings of the target repo in Github.
Scroll down to the bottom and you will find a column called Github Pages. There, set up the following

![](https://github.com/hrntsm/zenn_articles/blob/master/books/grasshopper-ci/image/Pages.png?raw=true)

Then select Choose a Theme in the Theme Chooser section below it to choose a theme for your pages.
Choose the one you want.
As an example, choose the Cayman theme, which is the first choice, and commit it first.
Then CI runs in the background, and the page is created based on the contents of docs/index.md.
The created page can be accessed from Environments to the right of the repo.

![](https://github.com/hrntsm/zenn_articles/blob/master/books/grasshopper-ci/image/environment.png?raw=true)

The URL of the page is created by the following rules

https:// YOUR_ACOUNT_NAME .github.io/REPOSITORY_Name/

The content of the page will be displayed in a markdown format, so you can create a page as you wish to introduce it.
By the way, this is just a page from the folder you set up (in this case, doc in the main branch), so even if you put HTML and so on directly there, the page will be created.
This page is also created using GitHub Pages.

## Example

The pages created for your reference are listed below.

Contents of index.md [GrasshopperCISample/docs](https://github.com/hrntsm/GrasshopperCISample/tree/main/docs)

Deployed site [GrasshopperCISample](https://hrntsm.github.io/GrasshopperCISample/)

---

### Prev
[Add Badge to README](add-badge)

### Next
[Reference](reference)

[Return to Top](tutorial-chapters)
