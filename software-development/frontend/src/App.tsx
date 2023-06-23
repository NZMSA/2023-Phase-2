import React from 'react';
import logo from './logo.svg';
import './App.css';
import { ThemeProvider } from '@emotion/react';
import { lightTheme } from './themes';
import { useGetAllTodoListsQuery } from './api/apiSlice';
import { CircularProgress } from '@mui/material';
import { TodoList } from './stories/TodoList/TodoList';

function App() {
  const {data, isLoading, isError } = useGetAllTodoListsQuery();

  if(isLoading) return <CircularProgress />;
  if(isError) return <p>Oops, Something went wrong!</p>;

  return (
    //TODO: Hook theming up to redux so that it selects
    <ThemeProvider theme={lightTheme}>
      <div className="App">
        {data!.length === 0 && <p>No Todo Lists!</p>}
        {data!.map(tdl => <TodoList todoListItems={tdl.todoItemList} key={tdl.id}/>)}
      </div>
    </ThemeProvider>
  );
}

export default App;
