# 2023-Phase-2-Software-Development
---
Welcome to Phase 2! For software development, we have the following functional requirements:
  -  A front-end web application
  -  A back-end API or service layer
  -  A persistent database

Otherwise, the goal is simple - to build a fully functional full-stack application that does something awesome. You can talk to reddit API (RIP 👻 - that's no longer free), or discord API (yay, that's still free), or any third API of your choice to source any additional data you may or may not need.

The submission format will be a ten minute presentation with your live, deployed application, where you will be marked on the following criteria:
- Look and feel of the application UI
- Responsiveness and UX
- Authentication/Application security
- Offline behaviour
- Mobile device compatability
- Complexity of the application
- Cool factor 😎, or how awesome your idea is
- A walkthrough of your codebase

## Frond-end Application
---
We have put up some basic examples of how you may wish to structure your application components (see `TodoCard` and `TodoList`, and a basic implementation of storybook stories. You can find the examples in the front-end project. There are also some examples of how you can and should use something like redux toolkit (RTK) and RTK Query to handle your state, as well as an example of how to wire those together (see `App.tsx`).

If you need any additional examples of working front-end code, such as how to handle animations and transitions, or more complex front-end logic, please go check out last year's phase 2 example project.

You will find the following links helpful:
- [Storybook](https://storybook.js.org/docs/react/get-started/install/)
- [RTK and RTK Query](https://redux-toolkit.js.org/introduction/getting-started)
- [Material UI](https://mui.com/material-ui/getting-started/overview/)
  - This is a component library that adheres to Google's material design principles, and will be useful to provide a basic look and feel.
  - Alternatives to this inclue [Mantine](https://mantine.dev/), [Ant Design](https://ant.design/), and [Tailwind](https://tailwindcss.com/docs/installation)
- [Styled Components](https://styled-components.com/docs)
  - Material UI supports styled components, another way to declare styled html elements
  - The alternative is [Emotion](https://emotion.sh/docs/introduction)
- [Redux Extension](https://chrome.google.com/webstore/detail/redux-devtools/lmhkpmbekcpmknklioeibfkpmmfibljd)
  - This will let you take a peek in to the redux state and play it forwards or backwards, useful for debugging state issues
- [Chromatic](https://www.chromatic.com/)
  - This is useful for handling any kind of snapshot testing of your storybook components 

## Back-end Application
---
We expect you to build a functional backend API that is callable via either [Postman](https://www.postman.com/) or [Swagger](https://swagger.io/). We have provided you an example of a functional backend project in this library, for a basic Todo application with some simple authentication.

This backend can be built in any framework, though we **strongly** recommend that you build it with .NET, as this is what most of our employers are looking for.

You will find the following links helpful:
- [Automapper](https://automapper.org/)
  - A library that automatically maps objects from one format to another
  - This will make converting inputs and outputs simpler
- [Polly](https://github.com/App-vNext/Polly)
  - A library that handles backofff and retry policies for talking to databases or any other dependencies for resiliency
- [EF Core](https://learn.microsoft.com/en-us/ef/core/)
  - A library that allows you to programmatically handle calls to your SQL database
- [MediatR](https://github.com/jbogard/MediatR)
  - A library for allowing you to better use DI
- [FluentValidation](https://fluentvalidation.net/)
  - A library for ensuring that any arguments and requests are properly validated

## Getting Started
---
The easiest way to get started with those requirements would be to build off of the existing code given in this repository. 

The front-end folder is a create-react-app application that has been scaffolded out and has had storybook configured correctly to work for the project at hand. To use the front-end project as a starting point:
  - remove the models in the models folder
  - remove the contents of the stories folder
  - change `App.tsx` and empty out the component contents

The back-end folder is a C# 7 Web API project that has been set up as an example with some libraries and CORS set up correctly. To use the back-end project as a starting point:
  - remove all existing controllers in the `Controllers` folder
  - clear out any service registrations in `Startup.cs` related to example services
  - remove the contents of the `Services` folder
  - remove the contexts from the `Contexts` folder
  - remove all models from the `Models` folder

### Starting Fresh
---
If you wish to start fresh, then the best way to do so would be to follow the getting started instructions for these links:
  - (One Of These) Front-End Frameworks
    - [Create React App](https://create-react-app.dev/docs/getting-started)
      - You'll want to use the following command: `npx create-react-app my-app --template typescript`
    - [Next](https://nextjs.org/docs)
    - [SvelteKit](https://learn.svelte.dev/tutorial/introducing-sveltekit)
    - [Redwood.js](https://redwoodjs.com/docs/quick-start)
  - Backend
    - [Web API](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-7.0&tabs=visual-studio) 

## Office Hours
---
We will be online on discord during weekday evenings and some hours of the weekend to answer any questions that you may specifically have! Please check out the [discord server](https://discord.gg/pGPGGXQ6SC) for more information.

---
Good Luck Everyone, and happy hacking!

![Liftoff GIF](https://i.giphy.com/media/xiN0BXMETVsx0AxTXt/giphy.webp)
