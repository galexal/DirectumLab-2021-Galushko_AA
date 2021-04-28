import * as React from 'react';
import { Route, Switch } from 'react-router-dom';
import RegisterPage from '../page/registerPage';
import PlanningPage from '../page/planningPage';
import InvitePage from '../page/invitePage';
import NoMatchPage from '../page/noMatchPage';
import { Path } from '../../routes';

const App: React.FC<any> = () => {
  const props = {
    votingIsFinish: true
  }
  return (
    <Switch>
      <Route exact path={Path.REGISTER} component={RegisterPage}/>
      <Route exact path={`${Path.INVITE}/:id`} component={InvitePage}/>
      <Route exact path={`${Path.PLANNING}/:id`}
      component={PlanningPage}/>
      <Route component={NoMatchPage}/>
    </Switch>
  );
}

export default App;
