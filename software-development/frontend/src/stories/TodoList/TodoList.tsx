import { List, ListItem } from "@mui/material"
import { TodoCard } from "../TodoCard/TodoCard";
import { TodoItem } from "../../models/TodoItem";

export interface TodoListProps {
    todoListItems: TodoItem[];
}

const TodoList = ({ todoListItems }: TodoListProps) => 
{
    return <List>
        {todoListItems?.map((d : TodoItem) =>
            <ListItem key={d.id}>
                <TodoCard {...d} />
            </ListItem>)}
    </List>
}

export { TodoList };