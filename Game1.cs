using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Topic_1_Intro_to_monogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D dinoTexture;
        Rectangle dinoRect;
        Texture2D dino3Texture;
        Rectangle dinoRect3;
        Texture2D dino4Texture;
        Rectangle dinoRect4;
        Texture2D dino2Texture;
        Rectangle dinoRect2;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            
           
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.Window.Title = "Intro to MonoGame Pt1";
            _graphics.PreferredBackBufferWidth = 800; 
            _graphics.PreferredBackBufferHeight = 500; 
            _graphics.ApplyChanges();

            dinoRect = new Rectangle(230, 100, 75, 75);
            dinoRect2 = new Rectangle(300, 100, 75, 75);
            dinoRect3 = new Rectangle(100, 100, 75, 75);
            dinoRect4 = new Rectangle(200, 200, 75, 75);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            dinoTexture = Content.Load<Texture2D>("dino (1)");
            dino2Texture = Content.Load<Texture2D>("Dino2");
            dino3Texture = Content.Load<Texture2D>("Dino3");
            dino4Texture = Content.Load<Texture2D>("Dino4");


            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(dinoTexture, dinoRect, Color.White);
            _spriteBatch.Draw(dino2Texture,dinoRect2 , Color.White);
            _spriteBatch.Draw(dino3Texture,dinoRect3 , Color.White);
            _spriteBatch.Draw(dino4Texture,dinoRect4 , Color.White);



            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}