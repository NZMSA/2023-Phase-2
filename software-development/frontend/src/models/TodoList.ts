import { TodoItem } from "./TodoItem"

interface TodoList {
    createdBy: string,
    dateCreated: string,
    id: number,
    title: string,
    todoItemList: TodoItem[]
}

export type { TodoList }