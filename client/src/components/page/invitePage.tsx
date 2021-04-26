import * as React from 'react';
import Footer from '../footer/footer';
import Header from '../header/header';
import Main from '../main/main';
import InviteForm from '../form/inviteForm';
import {withRouter} from 'react-router-dom';
import {RouteComponentProps} from 'react-router';
import './page.css';

interface IProps extends RouteComponentProps {
  roomId?: number;
}

const InvitePage:React.FC<IProps> = ({
  roomId
}) => {
  return (
    <div className="page">
      <Header/>
      <Main className="main"><InviteForm roomId={roomId}/></Main>
      <Footer/>
    </div>
  );
}

export default withRouter(InvitePage);
