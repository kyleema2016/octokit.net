﻿#if NET_45
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
#endif

namespace Octokit
{
    /// <summary>
    /// A client for GitHub's Releases API.
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/repos/releases/">Releases API documentation</a> for more information.
    /// </remarks>
    public interface IReleasesClient
    {
        /// <summary>
        /// Gets all <see cref="Release"/>s for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#list-releases-for-a-repository">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The repository's owner</param>
        /// <param name="name">The repository's name</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<IReadOnlyList<Release>> GetAll(string owner, string name);

        /// <summary>
        /// Gets all <see cref="Release"/>s for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#list-releases-for-a-repository">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The repository's ID</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<IReadOnlyList<Release>> GetAll(int repositoryId);

        /// <summary>
        /// Gets all <see cref="Release"/>s for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#list-releases-for-a-repository">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The repository's owner</param>
        /// <param name="name">The repository's name</param>
        /// <param name="options">Options for changing the API response</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<IReadOnlyList<Release>> GetAll(string owner, string name, ApiOptions options);

        /// <summary>
        /// Gets all <see cref="Release"/>s for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#list-releases-for-a-repository">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The repository's ID</param>
        /// <param name="options">Options for changing the API response</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<IReadOnlyList<Release>> GetAll(int repositoryId, ApiOptions options);

        /// <summary>
        /// Gets a single <see cref="Release"/> for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#get-a-single-release">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The repository's owner</param>
        /// <param name="name">The repository's name</param>
        /// <param name="id">The id of the release</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get", Justification = "Method makes a network request")]
        Task<Release> Get(string owner, string name, int id);

        /// <summary>
        /// Gets a single <see cref="Release"/> for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#get-a-single-release">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The repository's ID</param>
        /// <param name="id">The id of the release</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get", Justification = "Method makes a network request")]
        Task<Release> Get(int repositoryId, int id);

        /// <summary>
        /// Gets the latest <see cref="Release"/> for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/releases/#get-the-latest-release">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The repository's owner</param>
        /// <param name="name">The repository's name</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<Release> GetLatest(string owner, string name);

        /// <summary>
        /// Gets the latest <see cref="Release"/> for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/releases/#get-the-latest-release">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The repository's ID</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<Release> GetLatest(int repositoryId);

        /// <summary>
        /// Creates a new <see cref="Release"/> for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#create-a-release">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The repository's owner</param>
        /// <param name="name">The repository's name</param>
        /// <param name="data">A description of the release to create</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<Release> Create(string owner, string name, NewRelease data);

        /// <summary>
        /// Creates a new <see cref="Release"/> for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#create-a-release">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The repository's ID</param>
        /// <param name="data">A description of the release to create</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<Release> Create(int repositoryId, NewRelease data);

        /// <summary>
        /// Edits an existing <see cref="Release"/> for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#edit-a-release">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The repository's owner</param>
        /// <param name="name">The repository's name</param>
        /// <param name="id">The id of the release</param>
        /// <param name="data">A description of the release to edit</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<Release> Edit(string owner, string name, int id, ReleaseUpdate data);

        /// <summary>
        /// Edits an existing <see cref="Release"/> for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#edit-a-release">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The repository's ID</param>
        /// <param name="id">The id of the release</param>
        /// <param name="data">A description of the release to edit</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<Release> Edit(int repositoryId, int id, ReleaseUpdate data);

        /// <summary>
        /// Deletes an existing <see cref="Release"/> for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#delete-a-release">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The repository's owner</param>
        /// <param name="name">The repository's name</param>
        /// <param name="id">The id of the release to delete</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task Delete(string owner, string name, int id);

        /// <summary>
        /// Deletes an existing <see cref="Release"/> for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#delete-a-release">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The repository's ID</param>
        /// <param name="id">The id of the release to delete</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task Delete(int repositoryId, int id);

        /// <summary>
        /// Gets all <see cref="ReleaseAsset"/> for the specified release of the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#list-assets-for-a-release">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The repository's owner</param>
        /// <param name="name">The repository's name</param>
        /// <param name="id">The id of the <see cref="Release"/>.</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<IReadOnlyList<ReleaseAsset>> GetAllAssets(string owner, string name, int id);

        /// <summary>
        /// Gets all <see cref="ReleaseAsset"/> for the specified release of the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#list-assets-for-a-release">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The repository's ID</param>
        /// <param name="id">The id of the <see cref="Release"/>.</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<IReadOnlyList<ReleaseAsset>> GetAllAssets(int repositoryId, int id);

        /// <summary>
        /// Gets all <see cref="ReleaseAsset"/> for the specified release of the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#list-assets-for-a-release">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The repository's owner</param>
        /// <param name="name">The repository's name</param>
        /// <param name="id">The id of the <see cref="Release"/>.</param>
        /// <param name="options">Options for changing the API response</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<IReadOnlyList<ReleaseAsset>> GetAllAssets(string owner, string name, int id, ApiOptions options);

        /// <summary>
        /// Gets all <see cref="ReleaseAsset"/> for the specified release of the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#list-assets-for-a-release">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The repository's ID</param>
        /// <param name="id">The id of the <see cref="Release"/>.</param>
        /// <param name="options">Options for changing the API response</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<IReadOnlyList<ReleaseAsset>> GetAllAssets(int repositoryId, int id, ApiOptions options);

        /// <summary>
        /// Uploads a <see cref="ReleaseAsset"/> for the specified release.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#upload-a-release-asset">API documentation</a> for more information.
        /// </remarks>
        /// <param name="release">The <see cref="Release"/> to attach the uploaded asset to</param>
        /// <param name="data">Description of the asset with its data</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<ReleaseAsset> UploadAsset(Release release, ReleaseAssetUpload data);

        /// <summary>
        /// Gets the specified <see cref="ReleaseAsset"/> for the specified release of the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#get-a-single-release-asset">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The repository's owner</param>
        /// <param name="name">The repository's name</param>
        /// <param name="assetId">The id of the <see cref="ReleaseAsset"/></param>
        Task<ReleaseAsset> GetAsset(string owner, string name, int assetId);

        /// <summary>
        /// Gets the specified <see cref="ReleaseAsset"/> for the specified release of the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#get-a-single-release-asset">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The repository's ID</param>
        /// <param name="assetId">The id of the <see cref="ReleaseAsset"/></param>
        Task<ReleaseAsset> GetAsset(int repositoryId, int assetId);

        /// <summary>
        /// Edits the <see cref="ReleaseAsset"/> for the specified release of the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#edit-a-release-asset">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The repository's owner</param>
        /// <param name="name">The repository's name</param>
        /// <param name="assetId">The id of the <see cref="ReleaseAsset"/></param>
        /// <param name="data">Description of the asset with its amended data</param>
        Task<ReleaseAsset> EditAsset(string owner, string name, int assetId, ReleaseAssetUpdate data);

        /// <summary>
        /// Edits the <see cref="ReleaseAsset"/> for the specified release of the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#edit-a-release-asset">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The repository's ID</param>
        /// <param name="assetId">The id of the <see cref="ReleaseAsset"/></param>
        /// <param name="data">Description of the asset with its amended data</param>
        Task<ReleaseAsset> EditAsset(int repositoryId, int assetId, ReleaseAssetUpdate data);

        /// <summary>
        /// Deletes the specified <see cref="ReleaseAsset"/> from the specified repository
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#delete-a-release-asset">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The repository's owner</param>
        /// <param name="name">The repository's name</param>
        /// <param name="id">The id of the <see cref="ReleaseAsset"/>.</param>
        Task DeleteAsset(string owner, string name, int id);

        /// <summary>
        /// Deletes the specified <see cref="ReleaseAsset"/> from the specified repository
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/releases/#delete-a-release-asset">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The repository's ID</param>
        /// <param name="id">The id of the <see cref="ReleaseAsset"/>.</param>
        Task DeleteAsset(int repositoryId, int id);
    }
}
