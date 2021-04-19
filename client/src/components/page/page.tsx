import * as React from 'react';
import Footer from '../footer/footer';
import Header from '../header/header';
import Main from '../main/main';
import './page.css';

function Page() {
  return (
    <div className="page">
      <Header/>
      <Main/>
      <Footer/>
    </div>
  );
}

export default Page;
