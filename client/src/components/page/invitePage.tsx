import * as React from 'react';
import Footer from '../footer/footer';
import Header from '../header/header';
import Logotype from '../logotype/logotype';
import Main from '../main/main';
import InviteForm from '../form/inviteForm';
import './page.css';

function InvitePage() {
  return (
    <div className="page">
      <Header/>
      <Main className="main"><InviteForm/></Main>
      <Footer/>
    </div>
  );
}

export default InvitePage;
