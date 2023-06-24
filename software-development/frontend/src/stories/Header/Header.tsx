import { AppBar, Toolbar } from "@mui/material";
import { PropsWithChildren } from 'react';

export interface HeaderProps extends PropsWithChildren {

}

const Header = ({ children }: HeaderProps) => {
    return <AppBar>
        <Toolbar>
            {children}
        </Toolbar>
    </AppBar>
}

export { Header }