import type { Meta, StoryObj } from '@storybook/react';

import { TodoCard } from './TodoCard';
import { within, userEvent } from '@storybook/testing-library';

// More on how to set up stories at: https://storybook.js.org/docs/react/writing-stories/introduction
const meta = {
  title: 'Components/Todo Card',
  component: TodoCard,
  tags: ['autodocs']
} satisfies Meta<typeof TodoCard>;

export default meta;
type Story = StoryObj<typeof meta>;

// More on writing stories with args: https://storybook.js.org/docs/react/writing-stories/args
export const BasicTodo: Story = {
  args: {
    title: "Run Phase 2 Meeting",
    createdBy: 'Nicholas Kondal',
    dateCreated: new Date().toString(),
    dateDue: new Date().toString(),
    id: 1,
    labels: [],
    state: 0,
    todoListId: 0,
    content: "Launch Phase 2!"
  },
};

export const TodoWithItem: Story = {
    args: {
      title: "Panick Write Phase 2",
      createdBy: 'Rodger Gu',
      dateCreated: new Date().toString(),
      dateDue: new Date().toString(),
      id: 1,
      labels: [],
      state: 0,
      todoListId: 0,
      content: "Quick, Write Phase 2!"
    },
    play: async ({args, canvasElement, step}) => {
      const canvas = within(canvasElement);

      await step('Click Share', async () => {
        await userEvent.click(canvas.getByTestId('todo-card-share'));
      });
      await step('Click Done', async () => {
        await userEvent.click(canvas.getByTestId('todo-card-done'));
      });
      await step('Click Close', async () => {
        await userEvent.click(canvas.getByTestId('todo-card-close'));
      });
    }
  };