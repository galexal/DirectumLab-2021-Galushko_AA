import * as React from 'react';
import Logotype from '../logotype/logotype';
import UserAcc from '../userAcc/userAcc';
import './header.css';

interface Props {
  userName?: string;
}

const Header: React.FC<Props> = ({
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
