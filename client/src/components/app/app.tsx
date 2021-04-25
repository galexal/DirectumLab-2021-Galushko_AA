import * as React from 'react';
import { Route, Switch } from 'react-router-dom';
import RegisterPage from '../page/registerPage';
import PlanningPage from '../page/planningPage';
import InvitePage from '../page/invitePage';
import NoMatchPage from '../page/noMatchPage';
import { Path } from '../../routes';
import Modal from '../modal/modal';


const App: React.FC<any> = () => {
  const props = {
    roomId: 42,
    votingIsFinish: true
  }
  return (
    <Switch>
      <Route exact path={Path.register} component={RegisterPage}/>
      <Route exact path={`${Path.invite}`} component={InvitePage}/>
      <Route exact path={`${Path.planning}/:${props.roomId}`} component={PlanningPage}/>
      <Route exact path={`${Path.planning}/:${props.roomId}/result`}
      render={()=><PlanningPage votingIsFinish={props.votingIsFinish}/>}
      />
      <Route exact path={`${Path.planning}/modal`} component={Modal}/>
      <Route path='/' component={NoMatchPage}/>
    </Switch>
  );
}

export default App;
