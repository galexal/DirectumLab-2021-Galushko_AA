import * as React from 'react';
import Footer from '../footer/footer';
import Header from '../header/header';
import Main from '../main/main';
import './page.css';
import Cards from '../cards/cards';
import Story from '../story/story';
import Sidebar from '../sidebar/sidebar';
import Result from '../result/result';

interface IProps {
  votingIsFinish?: boolean;
}

const PlanningPage: React.FC<IProps> = ({
  votingIsFinish
}) => {
  return (
    <div className="page">
      <Header userName="UserName"/>
      <Main className="main_planning-page">
        <h2 className="story-name">Story</h2>
        <div className="cards-or-result-with-sidebar">
          <div className="result-with-story">
            {votingIsFinish
              ? <Result
                  colors={["value_mark-yellow", "value_mark-red", "value_mark-green"]}
                  users={[{userName: "User1", vote: "42"},{userName: "User2", vote: "66"}]}
                />
              : <Cards values={['0', '0.5', '1', '2', '3', '5', '8', '13', '20', '40', '100', 'question', 'coffee']}/>
            }
            <Story
               stories={[
                {storyName: "Story1", avg: 8, users: [{userName: "User1", vote: 42}]},
                {storyName: "Story2", avg: 8, users: [{userName: "User2", vote: 66}]}
              ]}
            />
          </div>
          <Sidebar needHideVote users={[
            'User1', 'User2'
            //{name:'User1',vote:'5'}, 
            //{name:'User2',vote:'8'}
            ]}/>
        </div>
      </Main>
      <Footer/>
    </div>
  );
}

export default PlanningPage;
