import { Typography } from '@mui/material';
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
    description: "A meeting about the progress we have on our respective workshops",
    cardItems: [],
    cardKey: "TodoList.Items.0"
  },
};

export const TodoWithItem: Story = {
    args: {
      title: "Run Phase 2 Meeting",
      description: "A meeting about the progress we have on our respective workshops",
      cardItems: [
        <Typography>
            Some Text About Item One
        </Typography>
      ],
      cardKey: "TodoList.Items.0"
    },
    play: async ({args, canvasElement, step}) => {
      const canvas = within(canvasElement);

      await step('Click Share', async () => {
        await userEvent.click(canvas.getByLabelText('todo-card-share'));
      });
      await step('Click Done', async () => {
        await userEvent.click(canvas.getByLabelText('todo-card-done'));
      });
      await step('Click Close', async () => {
        await userEvent.click(canvas.getByLabelText('todo-card-close'));
      });
    }
  };