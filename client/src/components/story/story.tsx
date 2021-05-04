import * as React from 'react';
import download from '../../images/download_24px.svg';
import basket from '../../images/delete_24px.svg';
import './story.css';
import '../sidebar/sidebar.css';

interface IProps {
  stories?: Array <{id: string, name: string, average: number | null, votes: {[key: string]: string}}>;
  onModalOpenClose(storyId: string): void;
  onStoryDelete(storyId: string): void;
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
        <p className="stories-number">{stories?.length}</p>
        <a className="download" href=""><img src={download} alt="Иконка скачивания"/></a>
      </div>
      <table className="table">
        {stories?.map((story)=>
            <tr key={story.name}><td><button onClick={()=>onModalOpenClose(story.id)}>{story.name}</button></td><td>{story.average}</td><td ><button className="basket" onClick={()=>onStoryDelete(story.id)}><img src={basket} alt="Иконка корзины"/></button></td></tr>    
        )}
      </table>
    </div>
  );
};

export default Story;
