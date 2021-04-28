import * as React from 'react';
import Footer from '../footer/footer';
import Header from '../header/header';
import Main from '../main/main';
import './page.css';
import Cards from '../cards/cards';
import Story from '../story/story';
import Sidebar from '../sidebar/sidebar';
import Result from '../result/result';
import {withRouter} from 'react-router-dom';
import {RouteComponentProps} from 'react-router';
import Modal from '../modal/modal';


interface IMatchParams {
  id: string;
}

interface IProps extends RouteComponentProps<IMatchParams> {
  roomId: string;
}

interface IState {
  votingIsFinish?: boolean;
  modalIsOpen: boolean;
  modalStoryIndex: number;
  users: Array<{userName: string, vote: string}> | null;
  stories: Array <{storyName: string, avg: number, users: Array<{userName: string, vote: string}>}>;
}

class PlanningPage extends React.Component<IProps,IState,IMatchParams> {
  constructor (props: IProps) {
    super(props);
    this.state = {
      votingIsFinish: false,
      modalIsOpen: false,
      modalStoryIndex: 0,
      users: [
        {userName: "User1", vote: "42"},
        {userName: "User2", vote: "66"},
        {userName: "User3", vote: "18"},
        {userName: "User4", vote: "34"}
      ],
      stories: [
        {storyName: "Story1", avg: 16, users: [{userName: "User1", vote: "42"}]},
        {storyName: "Story2", avg: 8, users: [{userName: "User2", vote: "66"}]}
      ]
    };
    this.handleNewStoryClick=this.handleNewStoryClick.bind(this);
    this.handleModalClick=this.handleModalClick.bind(this);
    this.handleVotingFinishClick = this.handleVotingFinishClick.bind(this);
  }

  public handleVotingFinishClick ()  {
    this.setState({
      votingIsFinish: true
    });
  }

  public handleNewStoryClick() {
    this.setState({
      votingIsFinish: false
    });
  }

  public handleModalClick(storyIndex: number) {
      this.setState({
        modalIsOpen: !this.state.modalIsOpen,
        modalStoryIndex: storyIndex,
    });
  }

  public render () {
    const roomId = this.props.match.params.id;
    const {votingIsFinish} = this.state;
    const {modalIsOpen} = this.state;

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
                  users={this.state.users}
                />
              : <Cards values={['0', '0.5', '1', '2', '3', '5', '8', '13', '20', '40', '100', 'question', 'coffee']}/>
            }
            <Story
              onModalClick={this.handleModalClick}
              stories={this.state.stories}
            />
            {modalIsOpen && <Modal
              onModalClick={this.handleModalClick}
              users={this.state.stories[this.state.modalStoryIndex].users}
            />}
          </div>
          <Sidebar 
            onVotingFinishClick={this.handleVotingFinishClick}
            onNewStoryClick={this.handleNewStoryClick}
            roomId={roomId} 
            votingIsFinish={votingIsFinish} 
            needHideVote users={[
              {userName:"User1",vote:"5"}, 
              {userName:"User2",vote:"8"}
            ]}/>
        </div>
      </Main>
      <Footer/>
    </div>
  );
}}

export default withRouter(PlanningPage);
