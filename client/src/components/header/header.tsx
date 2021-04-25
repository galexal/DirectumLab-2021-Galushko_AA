import * as React from 'react';
import Logotype from '../logotype/logotype';
import UserAcc from '../userAcc/userAcc';
import './header.css';

interface IProps {
  userName?: string;
}

const Header: React.FC<IProps> = ({
  userName
}) => {
  return (
    <div className="header-container">
      <header className="header">
        <Logotype/>
        {
          userName && <UserAcc userName={userName}/>
        }
      </header>
    </div>
  );
};

export default Header;
