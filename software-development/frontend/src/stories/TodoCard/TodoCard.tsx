import { Close, Done, Share } from "@mui/icons-material";
import { Card, CardActions, CardContent, CardHeader, IconButton, styled } from "@mui/material";
import React from 'react';

export interface TodoCardProps {
    title : string,
    description: string,
    cardItems: JSX.Element[],
    cardKey: string,
    //TODO: Add some user posting details here
}

const StyledCard = styled(Card)(({theme}) => ({
    maxWidth: '500px'
}));

const TodoCard = ({title, description, cardItems} : TodoCardProps) => {
    return (<StyledCard>
        <CardHeader
            title={title}
            subheader={description}/>
        <CardContent>
            {cardItems}
        </CardContent>
        <CardActions sx={{alignContent: 'flex-end', justifyContent: 'end', alignSelf: 'end'}}>
            {/*TODO: Set up these actions correctly */}
            <IconButton >
                <Share data-testid="todo-card-share"/>
            </IconButton>
            <IconButton >
                <Done  data-testid="todo-card-done"/>
            </IconButton>
            <IconButton  >
                <Close data-testid="todo-card-close"/>
            </IconButton>
        </CardActions>
    </StyledCard>)
}

export { TodoCard };