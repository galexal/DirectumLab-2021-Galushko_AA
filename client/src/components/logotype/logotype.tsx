import * as React from 'react';
import { Link } from 'react-router-dom';
import logo from '../../images/pie_chart_24px.svg';
import { Path } from '../../routes';
import './logotype.css';

function Logotype() {
  return (
    <div className="header__logotype">
      <Link to={Path.REGISTER}>
        <img src={logo} alt="Иконка PlanPoker"/>
        <h1 className="header__name">PlanPoker</h1>
      </Link>
    </div>
  );
}

export default Logotype;
