import * as React from 'react';
import download from '../../images/download_24px.svg';
import basket from '../../images/delete_24px.svg';
import './story.css';
import '../sidebar/sidebar.css';

interface IProps {
  stories: Array <{id: number, storyName: string, avg: number, users: Array<{userName: string, vote: string|null}>}>;
  onModalOpenClose(storyId:number): void;
  onStoryDelete(storyId:number): void;
}

const Story: React.FC<IProps> = ({
  stories,
  onModalOpenClose,
  onStoryDelete
}) => {
  return (
    <div className="story">
      <div className="story-title">
        <p className="completed_stories">Completed Stories</p>
        <p className="stories-number">{stories.length}</p>
        <a className="download" href=""><img src={download} alt="Иконка скачивания"/></a>
      </div>
      <table className="table">
        {stories.map((story,id)=>
            <tr key={story.storyName}><td><button onClick={()=>onModalOpenClose(id)}>{story.storyName}</button></td><td>{story.avg}</td><td ><button className="basket" onClick={()=>onStoryDelete(id)}><img src={basket} alt="Иконка корзины"/></button></td></tr>    
        )}
      </table>
    </div>
  );
};

export default Story;
