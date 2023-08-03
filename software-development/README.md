# 2023-Phase-2-Software-Development
---
Welcome to Phase 2! For software development, we have the following functional requirements:
  -  A front-end web application
  -  A back-end API or service layer
  -  A persistent database

Otherwise, the goal is simple - to build a fully functional full-stack application that does something awesome. You can talk to the Reddit API (RIP 👻 - that's no longer free), or the Discord API (yay, that's still free), or any third API of your choice to source any additional data you may or may not need.

## Submission

Submission will take place via a submission form, and you will be required to submit:

1. Link/s to your code repository/ies

2. A link to your live, deployed application that the MSA team can access

3. A (maximum) 10-minute presentation (in whatever format you choose, so long as your audio and any screenshares are clear and visible) that you record yourself and share a link to so that the MSA team can watch it. In your video, please:
  - Describe the features you implemented, why you implemented those features, and how you implemented those features (so that the MSA team can see that you actually understand what you built and how it's all put together)
  - Depending on the complexity of your application and the time available in your presentation, a brief walkthrough of your codebase would also be nice but not mandatory
  - Note: You can submit presentations longer than 10 minutes, but they may be penalised - the time limit is there to assess if students can explain the technical aspects of their work in a clear and concise way to someone like a developer wanting to get an overview of your application in order for them to continue developing it. So aim to present within 10 minutes, as the MSA team will be able to assess the details of your work through the link to the deployed application and your code repository/ies.

The three submission items above will be used to mark your submission on the following criteria:
- Look and feel of the application UI
- Responsiveness and UX
- Authentication/Application security
- Offline behaviour
- Mobile device compatibility
- Complexity of the application
- Cool factor 😎, or how awesome your idea is
- Extent of use of Microsoft technologies (C#, TypeScript, .NET, Azure etc.)

## Front-end Application
---
We have put up some basic examples of how you may wish to structure your application components (see `TodoCard` and `TodoList`, and a basic implementation of storybook stories. You can find the examples in the front-end project. There are also some examples of how you can and should use something like redux toolkit (RTK) and RTK Query to handle your state, as well as an example of how to wire those together (see `App.tsx`).

If you need any additional examples of working front-end code, such as how to handle animations and transitions, or more complex front-end logic, please go check out last year's phase 2 example project.

You will find the following links helpful:
- [Storybook](https://storybook.js.org/docs/react/get-started/install/)
- [RTK and RTK Query](https://redux-toolkit.js.org/introduction/getting-started)
- [Material UI](https://mui.com/material-ui/getting-started/overview/)
  - This is a component library that adheres to Google's material design principles, and will be useful to provide a basic look and feel.
  - Alternatives to this include [Mantine](https://mantine.dev/), [Ant Design](https://ant.design/), and [Tailwind](https://tailwindcss.com/docs/installation)
- [Styled Components](https://styled-components.com/docs)
  - Material UI supports styled components, another way to declare styled html elements
  - The alternative is [Emotion](https://emotion.sh/docs/introduction)
- [Redux Extension](https://chrome.google.com/webstore/detail/redux-devtools/lmhkpmbekcpmknklioeibfkpmmfibljd)
  - This will let you take a peek into the redux state and play it forwards or backwards, useful for debugging state issues
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
  - A library that handles backoff and retry policies for talking to databases or any other dependencies for resiliency
- [EF Core](https://learn.microsoft.com/en-us/ef/core/)
  - A library that allows you to programmatically handle calls to your SQL database
- [MediatR](https://github.com/jbogard/MediatR)
  - A library for allowing you to better use dependency injection
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

Feel free to refer to the past 3 years of [past MSA workshops](https://www.youtube.com/@microsoftstudentacceleratornz/videos) to help you complete this phase!

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
We will be online on Discord during weekday evenings and some hours of the weekend to answer any questions that you may specifically have! Please check out the [discord server](https://discord.gg/pGPGGXQ6SC) for more information.

---
Good Luck everyone, and happy hacking!

![Liftoff GIF](https://i.giphy.com/media/xiN0BXMETVsx0AxTXt/giphy.webp)
