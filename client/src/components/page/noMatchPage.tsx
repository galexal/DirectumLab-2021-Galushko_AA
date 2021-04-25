import * as React from 'react';
import Footer from '../footer/footer';
import Header from '../header/header';
import Main from '../main/main';
import './page.css';

function NoMatchPage() {
  return (
    <div className="page">
      <Header/>
      <Main className="main">
        <h1 style={{color: '#4B9AE8'}}>Страница не найдена</h1>
      </Main>
      <Footer/>
    </div>
  );
}

export default NoMatchPage;
