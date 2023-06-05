import { Close, Done, Share } from "@mui/icons-material";
import { Avatar, Card, CardActions, CardContent, CardHeader, IconButton } from "@mui/material";

export interface TodoCardProps {
    title : string,
    description: string,
    cardItems: JSX.Element[],
    cardKey: string,
    //TODO: Add some user posting details here
}

const TodoCard = ({title, description, cardItems} : TodoCardProps) => {
    return (<Card>
        <CardHeader
            title={title}
            subheader={description}/>
        <CardContent>
            {cardItems}
        </CardContent>
        <CardActions>
            {/*TODO: Set up these actions correctly */}'
            <IconButton className="todo-card-share">
                <Share />
            </IconButton>
            <IconButton className="todo-card-done">
                <Done />
            </IconButton>
            <IconButton className="todo-card-close">
                <Close />
            </IconButton>
        </CardActions>
    </Card>)
}

export { TodoCard };