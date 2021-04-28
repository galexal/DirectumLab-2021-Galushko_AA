import * as React from 'react';
import Footer from '../footer/footer';
import Header from '../header/header';
import Main from '../main/main';
import InviteForm from '../form/inviteForm';
import {withRouter} from 'react-router-dom';
import {RouteComponentProps} from 'react-router';
import './page.css';

interface IMatchParams {
  id: string;
}

interface IProps extends RouteComponentProps<IMatchParams> {
  roomId: string;
}

class InvitePage extends React.Component<IProps,IMatchParams> {
  constructor (props:IProps) {
    super(props);
  }
public render() {
  const roomId=this.props.match.params.id;
  return (
    <div className="page">
      <Header/>
      <Main className="main"><InviteForm roomId={roomId}/></Main>
      <Footer/>
    </div>
  );
}}


export default withRouter(InvitePage);
