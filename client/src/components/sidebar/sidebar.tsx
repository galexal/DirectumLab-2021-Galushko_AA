import * as React from 'react';
import userIcon from '../../images/User_Icon.svg';
import './sidebar.css';
import { Path } from '../../routes';

interface IProps {
    users: Array<{userName: string, vote: string|null}> | null;
    votingIsFinish?: boolean;
    roomId: string;
    onVotingFinishClick(): void;
    onNewStoryClick(storyName: string): void;
}

interface IState {
  storyName: string;
}

class Sidebar extends React.Component<IProps,IState> {
  constructor (props: IProps) {
    super(props);
    this.state = {
      storyName: ""
  };
  this.onChangeStoryName=this.onChangeStoryName.bind(this);
}

onChangeStoryName(e: any) {
  const val = e.target.value;
  this.setState({storyName: val});
}

  public render () {

  return (
    <div className="sidebar">
      <p className="sidebar__header">Story voting completed</p>
      <h3 className="players">Players:</h3>
      {this.props.users && this.props.users.map((user)=>
        <div key={user.userName} className="user-in-sidebar">
          <img src={userIcon} width="48" height="48" alt="Аватарка пользователя"/>
          <p className="user-in-story">{user.userName}</p>
          {user.vote && <svg className="check" width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
                <path fillRule="evenodd" clipRule="evenodd" d="M0 10C0 4.48 4.48 0 10 0C15.52 0 20 4.48 20 10C20 15.52 15.52 20 10 20C4.48 20 0 15.52 0 10ZM3 10L8 15L17 6L15.59 4.58L8 12.17L4.41 8.59L3 10Z" fill="#4B9AE8" fillOpacity="0.54"/>
            </svg>
          }
        </div>
      )}
      {this.props.votingIsFinish
        ? <div className="new-story">
            <input className="new-story_input" type="text" value={this.state.storyName} onChange={this.onChangeStoryName} placeholder="Enter new discussion name" required/>
            <button className="new-story_button" onClick={()=>this.props.onNewStoryClick(this.state.storyName)}>Go</button>
          </div>
        : <button className="finish_button" onClick={this.props.onVotingFinishClick}>Finish Voting</button>  
      }
      <div className="invite">
        <h3 className="invite_header">Invite a teammate</h3>
        <input className="invite_input" type="text" value={`${window.location.origin}${Path.INVITE}/${this.props.roomId}`} readOnly/>
      </div>
    </div>
  );
}}

export default Sidebar;
