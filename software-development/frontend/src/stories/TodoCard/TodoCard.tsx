import { Close, Done, Share } from "@mui/icons-material";
import { Card, CardActions, CardContent, CardHeader, IconButton, styled } from "@mui/material";
import React from 'react';

export interface TodoCardProps {
    content: string,
    createdBy: string,
    dateCreated: string,
    dateDue: string,
    id: number,
    labels: string[],
    state: number,
    title: string,
    todoListId: number
}

const StyledCard = styled(Card)(({ theme }) => ({
    maxWidth: '500px'
}));

const TodoCard = ({ content, createdBy, dateCreated, dateDue, id, labels, state, title, todoListId }: TodoCardProps) => {
    return (<StyledCard>
        <CardHeader
            title={title}
            subheader={`Created By: ${createdBy}`} />
        <CardContent>
            {content}
        </CardContent>
        <CardActions sx={{ alignContent: 'flex-end', justifyContent: 'end', alignSelf: 'end' }}>
            {/*TODO: Set up these actions correctly */}
            <IconButton >
                <Share data-testid="todo-card-share" />
            </IconButton>
            <IconButton >
                <Done data-testid="todo-card-done" />
            </IconButton>
            <IconButton  >
                <Close data-testid="todo-card-close" />
            </IconButton>
        </CardActions>
    </StyledCard>)
}

export { TodoCard };