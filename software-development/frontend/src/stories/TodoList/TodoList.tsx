import { CircularProgress, List, ListItem, Typography } from "@mui/material"
import { useGetAllTodoItemsQuery } from "../../api/apiSlice"
import { TodoCard } from "../TodoCard/TodoCard";

export interface TodoListProps {

}

const TodoList = ({ }: TodoListProps) => {
    const { data, isLoading, isError } = useGetAllTodoItemsQuery("");

    if (isLoading) return <CircularProgress></CircularProgress>;
    if (isError) return <Typography variant="h1">Failed To Fetch Todo Items</Typography>

    return <List>
        {data?.map(d =>
            <ListItem>
                <TodoCard {...d} cardItems={[]} />
            </ListItem>)}
    </List>
}

export { TodoList }