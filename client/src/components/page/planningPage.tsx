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
  storyName: string;
  avg: number;
  votingIsFinish?: boolean;
  modalStoryId?: number;
  selectedItem: string | null;
  users: Array<{userName: string, vote: string|null}>;
  stories: Array <{id: number, storyName: string, avg: number, users: Array<{userName: string, vote: string|null}>}>;
}

class PlanningPage extends React.Component<IProps,IState,IMatchParams> {
  constructor (props: IProps) {
    super(props);
    this.state = {
      storyName: "",
      avg: 0,
      votingIsFinish: true,
      modalStoryId: undefined,
      selectedItem: null,
      users: [
        {userName: "User1", vote: null},
        {userName: "User2", vote: "42"},
        {userName: "User3", vote: "18"},
        {userName: "User4", vote: "34"}
      ],
      stories: [
        {id: 123, storyName: "Story1", avg: 16, users: [{userName: "User1", vote: "42"}]},
        {id: 456, storyName: "Story2", avg: 8, users: [{userName: "User2", vote: "66"}]}
      ]
    };
    this.handleNewStoryClick=this.handleNewStoryClick.bind(this);
    this.handleModalOpenClose=this.handleModalOpenClose.bind(this);
    this.handleVotingFinishClick = this.handleVotingFinishClick.bind(this);
    this.handleStoryDelete=this.handleStoryDelete.bind(this);
    this.handleCardSelect=this.handleCardSelect.bind(this);
   }

   public getAvg () {
    let sum=0;
    this.state.users?.forEach(
      function sumNumber(user) {
        if (user.vote != undefined){
          sum+=parseInt(user.vote);
        }
    })
    return this.state.users ? sum/this.state.users.length : 0
}

  public handleVotingFinishClick ()  {
    const storyId = Math.round(Math.random()*(100-1)+1);
    const story ={id:storyId, storyName: this.state.storyName, avg: this.getAvg(), users: this.state.users };
    const stories = this.state.stories?.slice();
    stories?.push(story)
    this.setState({
      votingIsFinish: true,
      avg: this.getAvg(),
      stories
    });
  }

  public handleNewStoryClick(story: string) {
    this.setState({
      votingIsFinish: false,
      storyName: story
    });
  }

  public handleModalOpenClose(storyId: number|undefined) {
      this.setState({
        modalStoryId: storyId,
    });
  }

  public handleStoryDelete(storyId: number) {
    this.setState((prevState)=> ({
      stories: prevState.stories?.filter(s=>s.id!==storyId)
    }))
}

public handleCardSelect(cardValue: string) {
    const users = this.state.users?.slice();
    let selectedItem = this.state.selectedItem;
    selectedItem=cardValue;
    users[0].vote===cardValue
    ? (users[0].vote=null, selectedItem=null)
    : users[0].vote=cardValue
    this.setState({ users, selectedItem });
}

  public render () {
    const {votingIsFinish} = this.state;

  return (
    <div className="page">
      <Header userName="UserName"/>
      <Main className="main_planning-page">
        <h2 className="story-name">{this.state.storyName}</h2>
        <div className="cards-or-result-with-sidebar">
          <div className="result-with-story">
            {votingIsFinish
              ? <Result
                  avg={this.state.avg}
                  colors={["value_mark-yellow", "value_mark-red", "value_mark-green"]}
                  users={this.state.users}
                />
              : <Cards 
                  values={['0', '0.5', '1', '2', '3', '5', '8', '13', '20', '40', '100', 'question', 'coffee']}
                  onCardSelect={this.handleCardSelect}
                  selectedItem={this.state.selectedItem}
                  />
            }
            <Story
              onStoryDelete={this.handleStoryDelete}
              onModalOpenClose={this.handleModalOpenClose}
              stories={this.state.stories}
            />
            {this.state.modalStoryId!=null && <Modal
              onModalOpenClose={this.handleModalOpenClose}
              users={this.state.stories[this.state.modalStoryId]?.users}
            />}
          </div>
          <Sidebar 
            onVotingFinishClick={this.handleVotingFinishClick}
            onNewStoryClick={this.handleNewStoryClick}
            votingIsFinish={votingIsFinish} 
            users={this.state.users}
            />
        </div>
      </Main>
      <Footer/>
    </div>
  );
}}

export default withRouter(PlanningPage);
