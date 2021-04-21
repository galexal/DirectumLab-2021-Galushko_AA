import * as React from 'react';
import Footer from '../footer/footer';
import Header from '../header/header';
import Main from '../main/main';
import './page.css';
import Cards from '../cards/cards';
import Story from '../story/story';
import Sidebar from '../sidebar/sidebar';

function PlanningPage() {
  return (
    <div className="page">
      <Header userName="UserName"/>
      <Main className="main_planning-page">
        <h2 className="story-name">Story</h2>
        <div className="cards-or-result-with-sidebar">
          <div className="result-with-story">
            <Cards values={[0, 0.5, 1, 2, 3, 5, 8, 13, 20, 40, 100]}/>
            <Story
              storiesNumber={5}
              storyName="StoryName"
              avg={14}
            />
          </div>
          <Sidebar isChecked users={['User1', 'User2']}/>
        </div>
      </Main>
      <Footer/>
    </div>
  );
}

export default PlanningPage;
