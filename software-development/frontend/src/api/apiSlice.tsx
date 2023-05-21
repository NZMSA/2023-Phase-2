// Need to use the React-specific entry point to import createApi
import { createApi, fetchBaseQuery } from '@reduxjs/toolkit/query/react'

// Define a service using a base URL and expected endpoints
export const api = createApi({
    reducerPath: 'api',
    baseQuery: fetchBaseQuery({ baseUrl: '/api' }),
    endpoints: (builder) => ({
        getAllTodoItems: builder.query({
            query: () => 'TodoItem',
        }),

        getTodoItemById: builder.query({
            query: (id) => `TodoItem/${id}`,
        }),

        updateTodoItem: builder.mutation({
            query: (todoItem) => ({
                url: `TodoItem/${todoItem.Id}`,
                method: 'PUT',
                body: todoItem,
            }),
        }),
        
        createTodoItem: builder.mutation({
            query: (todoItem) => ({
                url: 'TodoItem',
                method: 'POST',
                body: todoItem,
            })
        }),

        deleteTodoItem: builder.mutation({
            query: (id) => ({
                url: `TodoItem/${id}`,
                method: 'DELETE',
            })
        })
    }),
})

// Export hooks for usage in functional components, which are
// auto-generated based on the defined endpoints
export const { useGetAllTodoItemsQuery, useGetTodoItemByIdQuery, useUpdateTodoItemMutation, useCreateTodoItemMutation, useDeleteTodoItemMutation } = api