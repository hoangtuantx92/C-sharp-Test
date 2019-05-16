using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    class VideoServiceTests
    {
        private Mock<IFileReader> _fileReader;
        private VideoService _videoService;
        private Mock<IVideoRepo> _repo;

        [SetUp]
        public void SetUp()
        {
            _fileReader = new Mock<IFileReader>();
            _repo = new Mock<IVideoRepo>();
            _videoService = new VideoService(fileReader: _fileReader.Object,repository: _repo.Object);
        }

        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");

            var result = _videoService.ReadVideoTitle();

            Assert.That(result, Is.EqualTo("Error parsing the video."));
        }

        [Test]
        public void GetUnprocessedVideo_AllVideosAreProcessed_ReturnEmptyString()
        {
            _repo.Setup(rp => rp.GetUnprocesssedVideos()).Returns(new List<Video>());

            var result = _videoService.GetUnprocessedVideosAsCsv();

            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        public void GetUnprocessedVideo_SomeVideosAreUnprocessed_ReturnNumberOfVideo()
        {
            _repo.Setup(rp => rp.GetUnprocesssedVideos()).Returns(new List<Video>
                {
                new Video {Id = 1},
                new Video {Id = 2},
                new Video {Id = 3}
            });

            var result = _videoService.GetUnprocessedVideosAsCsv();

            Assert.That(result, Is.EqualTo("1,2,3"));
        }
    }
}
