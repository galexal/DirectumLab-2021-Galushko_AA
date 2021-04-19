import * as React from 'react';
import Logotype from '../logotype/logotype';
import './header.css';

function Header() {
  return (
    <div className="header-container">
      <header className="header">
        <Logotype/>
      </header>
    </div>
  );
}

export default Header;
