interface TodoItem {
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

export type { TodoItem };