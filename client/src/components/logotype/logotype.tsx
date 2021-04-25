import * as React from 'react';
import logo from '../../images/pie_chart_24px.svg';
import { Path } from '../../routes';
import './logotype.css';

function Logotype() {
  return (
    <div className="header__logotype">
      <a href={Path.register}>
        <img src={logo} alt="Иконка PlanPoker"/>
        <h1 className="header__name">PlanPoker</h1>
      </a>
    </div>
  );
}

export default Logotype;
