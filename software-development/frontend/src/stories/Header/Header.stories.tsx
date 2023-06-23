import { Menu } from '@mui/icons-material';
import { Button, IconButton } from '@mui/material';
import type { Meta, StoryObj } from '@storybook/react';

import { Header } from './Header';

// More on how to set up stories at: https://storybook.js.org/docs/react/writing-stories/introduction
const meta = {
  title: 'Components/Header',
  component: Header,
  tags: ['autodocs']
} satisfies Meta<typeof Header>;

export default meta;
type Story = StoryObj<typeof meta>;

// More on writing stories with args: https://storybook.js.org/docs/react/writing-stories/args
export const EmptyHeader: Story = {
  args: {
  },
};

export const BasicHeader: Story = {
  args: {
    children: [
        <Button color="secondary">Basic Button</Button>,
        <IconButton>
          <Menu />
        </IconButton>
    ]
  },
};