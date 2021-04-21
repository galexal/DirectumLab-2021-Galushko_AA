import * as React from 'react';
import logo from '../../images/pie_chart_24px.svg';
import './logotype.css';

function Logotype() {
  return (
    <div className="header__logotype">
      <a href="#">
        <img src={logo} alt="Иконка PlanPoker"/>
        <h1 className="header__name">PlanPoker</h1>
      </a>
    </div>
  );
}

export default Logotype;
