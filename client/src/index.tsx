import React from 'react';
import ReactDOM from 'react-dom';
// import InvitePage from './components/page/invitePage';
// import RegisterPage from './components/page/registerPage';
import PlanningPage from './components/page/planningPage';

ReactDOM.render(
    <React.StrictMode>
      {/* <RegisterPage/> */}
      {/* <InvitePage/> */}
      <PlanningPage votingIsFinish />
    </React.StrictMode>,
    document.getElementById(`root`)
);
